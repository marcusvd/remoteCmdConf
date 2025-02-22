using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ServiceProcess;
using Microsoft.Management.Infrastructure;

public class ServiceUserAccount
{
    string serviceName = "remoteCmd";
    public bool ChangeUserAccontService(string serviceUserName, string servicePassword)
    {
        if (!string.IsNullOrEmpty(serviceUserName) && !string.IsNullOrEmpty(servicePassword))
        {
            string newAccount = serviceUserName; // Ou "DOMINIO\\Usuario"
            string newPassword = servicePassword; // Deixe em branco para contas do sistema

            string netWorkServiceUser = "NT AUTHORITY\\NetworkService"; // Ou "DOMINIO\\Usuario"
            string netWorkServicePassword = ""; // Deixe em branco para contas do sistema

            // Verifica se o serviço existe
            ServiceController sc = new ServiceController(serviceName);
            if (sc == null)
                MessageBox.Show($"Service {serviceName} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            try
            {
                GrantLogonAsServiceRight(newAccount);
                MessageBox.Show($"Sign in as a service' permission granted to account: {newAccount}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error granting permission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Altera a conta de serviço
            try
            {
                // Cria uma sessão CIM (Common Information Model) para interagir com o WMI
                using (CimSession session = CimSession.Create(null))
                {
                    // Define o namespace e o nome do serviço
                    string namespaceName = @"root\cimv2";
                    string query = $"SELECT * FROM Win32_Service WHERE Name = '{serviceName}'";

                    // Executa a consulta WMI
                    foreach (CimInstance instance in session.QueryInstances(namespaceName, "WQL", query))
                    {
                        // Prepara os parâmetros para o método "Change"
                        CimMethodParametersCollection parameters = new CimMethodParametersCollection
                    {
                        CimMethodParameter.Create("StartName", newAccount, CimFlags.None),
                        CimMethodParameter.Create("StartPassword", newPassword, CimFlags.None)
                    };

                        // Invoca o método "Change" para alterar a conta de serviço
                        CimMethodResult result = session.InvokeMethod(instance, "Change", parameters);

                        // Verifica se a operação foi bem-sucedida
                        if ((int)result.ReturnValue.Value == 0)
                        {
                            MessageBox.Show($"Service {serviceName} changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show($"Service {serviceName} not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show($"Service {serviceName} not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // MessageBox.Show($"Service {serviceName} not changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
    }

    static void GrantLogonAsServiceRight(string accountName)
    {
        try
        {
            // Converte o nome da conta para um SecurityIdentifier
            NTAccount account = new NTAccount(accountName);
            SecurityIdentifier sid = (SecurityIdentifier)account.Translate(typeof(SecurityIdentifier));

            // Define o direito de usuário "SeServiceLogonRight"
            string userRights = "SeServiceLogonRight";

            // Adiciona o SID da conta ao direito de usuário
            using (var policy = new LocalSecurityPolicy())
            {
                policy.AddAccountRights(sid, userRights);
            }
        }
        catch (IdentityNotMappedException)
        {
            MessageBox.Show($"A conta '{accountName}' não foi encontrada ou não é válida.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao conceder permissão: {ex.Message}");
        }
    }


}

public class LocalSecurityPolicy : IDisposable
{
    private IntPtr _policyHandle;

    public LocalSecurityPolicy()
    {
        // Abre a política de segurança local
        NativeMethods.LSA_OBJECT_ATTRIBUTES objectAttributes = new NativeMethods.LSA_OBJECT_ATTRIBUTES();
        objectAttributes.Length = Marshal.SizeOf(typeof(NativeMethods.LSA_OBJECT_ATTRIBUTES));

        // Abre a política de segurança local
        if (NativeMethods.LsaOpenPolicy(
            IntPtr.Zero,
            ref objectAttributes, // Passa a referência da estrutura
            NativeMethods.POLICY_ALL_ACCESS,
            out _policyHandle) != 0)
        {
            throw new Exception("Falha ao abrir a política de segurança local.");
        }
    }

    public void AddAccountRights(SecurityIdentifier sid, string userRights)
    {
        // Adiciona o direito de usuário à conta
        if (NativeMethods.LsaAddAccountRights(
            _policyHandle,
            sid,
            new string[] { userRights },
            1) != 0)
        {
            throw new Exception("Falha ao adicionar o direito de usuário.");
        }
    }

    public void Dispose()
    {
        if (_policyHandle != IntPtr.Zero)
        {
            NativeMethods.LsaClose(_policyHandle);
            _policyHandle = IntPtr.Zero;
        }
    }
}

// Métodos nativos para interagir com a API do Windows
internal static class NativeMethods
{
    public const uint POLICY_ALL_ACCESS = 0x00F0FFF;

    [StructLayout(LayoutKind.Sequential)]
    public struct LSA_OBJECT_ATTRIBUTES
    {
        public int Length;
        public IntPtr RootDirectory;
        public IntPtr ObjectName;
        public uint Attributes;
        public IntPtr SecurityDescriptor;
        public IntPtr SecurityQualityOfService;
    }

    [DllImport("advapi32.dll", SetLastError = true, PreserveSig = true)]
    public static extern uint LsaOpenPolicy(
        IntPtr SystemName,
        ref LSA_OBJECT_ATTRIBUTES ObjectAttributes,
        uint DesiredAccess,
        out IntPtr PolicyHandle);

    [DllImport("advapi32.dll", SetLastError = true, PreserveSig = true)]
    public static extern uint LsaAddAccountRights(
        IntPtr PolicyHandle,
        SecurityIdentifier AccountSid,
        string[] UserRights,
        uint CountOfRights);

    [DllImport("advapi32.dll", SetLastError = true, PreserveSig = true)]
    public static extern uint LsaClose(IntPtr ObjectHandle);
}
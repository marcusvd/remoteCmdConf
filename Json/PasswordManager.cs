using System.Security.Cryptography;

namespace remoteCmdConf;

public class PasswordManager
{
    public static (string Hash, string Salt) GenerateHashESalt(string password)
    {
        //Security salt 
        byte[] saltBytes = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(saltBytes);
        }
        string salt = Convert.ToBase64String(saltBytes);

        // Generate hash using PBKDF2
        var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256);
        byte[] hashBytes = pbkdf2.GetBytes(32);
        string hash = Convert.ToBase64String(hashBytes);

        return (hash, salt);
    }

    public static bool CheckPassword(string senha, string hashStored, string saltStored)
    {
        byte[] saltBytes = Convert.FromBase64String(saltStored);

        var pbkdf2 = new Rfc2898DeriveBytes(senha, saltBytes, 100000, HashAlgorithmName.SHA256);
        byte[] hashBytes = pbkdf2.GetBytes(32);
        string hash = Convert.ToBase64String(hashBytes);

        return hash == hashStored;
    }
}


// static void VerificarUsuario()
// {
//     // Ler o JSON
//     string jsonString = File.ReadAllText("usuario.json");
//     Usuario usuario = JsonSerializer.Deserialize<Usuario>(jsonString);

//     Console.Write("Digite sua senha para verificação: ");
//     string senha = Console.ReadLine();

//     bool senhaValida = GerenciadorDeSenhas.VerificarSenha(senha, usuario.HashDaSenha, usuario.Salt);

//     if (senhaValida)
//     {
//         Console.WriteLine("A senha está correta!");
//     }
//     else
//     {
//         Console.WriteLine("Senha incorreta!");
//     }
// }
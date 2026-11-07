using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

class Usuarios
{

    public static List<string> nomes = new List<string>();
    public static List<string> logins = new List<string>();
    public static List<string> senhas = new List<string>();
    
    public static void Cadastrar()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Usuário: ");
        string login = Console.ReadLine();
        Console.Write("Senha (mínimo 4 caracteres): ");
        string senha = Console.ReadLine();

        if (login == "" || senha.Length < 4)
        {
            Console.WriteLine("Dados inválidos!");
        }
        else if (logins.Contains(login))
        {
            Console.WriteLine("Esse usuário já existe!");
        }
        else
        {
            nomes.Add(nome);
            logins.Add(login);
            senhas.Add(senha);
            Console.WriteLine("Usuário cadastrado!");
        }
    }
    
    public static void Listar()
    {
        if (nomes.Count == 0)
        {
            Console.WriteLine("Nenhum usuário cadastrado.");
            return;
        }
        
        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + nomes[i] + " (" + logins[i] + ")");
       }
    }
    public static void Buscar()
    {
        Console.Write("Buscar por nome: ");
        string termo = Console.ReadLine().ToLower();

        bool encontrado = false;
        
        for (int i = 0; i < nomes.Count; i++)
        {
            if (nomes[i].ToLower().Contains(termo))
            {
                Console.WriteLine(nomes[i] + " (" + logins[i] + ")");
                encontrado = true;
            }

        }
        
        if(encontrado == false)
        {

            Console.WriteLine("Usuário não encontrado.");

        }

    }

    public static void Remover()
    {
        Console.Write("Usuário a remover: ");
        string login = Console.ReadLine();
        int i = logins.IndexOf(login);

        if (i == -1)
        {
            Console.WriteLine("Usuário nõa encontrado.");
            return;
        }
        else
        {
            Console.WriteLine("Usuário não existe.");
        }

        nomes.RemoveAt(i);
        logins.RemoveAt(i);
        senhas.RemoveAt(i);
        Console.WriteLine("Usuário removido!");
    }
} 
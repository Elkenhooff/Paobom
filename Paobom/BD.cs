﻿using System.Drawing.Drawing2D;

namespace Paobom
{
    public class BD
    {
        static string servidor = "127.0.0.1"; // Seu servidor MySQL local
        //static string porta = "3306";         // Porta do seu servidor MySQL
        static string usuario = "root";      // Usuário do banco de dados
        static string senha = "";            // Senha do banco de dados
        static string nomeBanco = "paobom"; // Nome do banco de dados que você deseja conectar

        public static string StringConexao = $"server={servidor};user={usuario};password={senha};database={nomeBanco};";


        //public static string StringConexao
        //{
        //    get //Obter a string
        //    {
        //        return $"server={servidor};user={usuario};password={senha};database={nomeBanco};";
        //    }
        //}

        //public static string caminhoBanco = ""; // Variável criada para indicar o caminho do banco (Onde está localizado o arquivo do banco de dados .mdf)
        //public static string ProcurarArquivo(string nomeArquivo)
        //{
        //    string caminhoUsuario = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); // Pega o caminho do usuário 'Exemplo : C:\Users\usuario'
        //    string caminhoDownloads = Path.Combine(caminhoUsuario, "Downloads"); // Adiciona o caminho do usuário + 'Downloads' o que indica que ele pegárá o caminho de Downloads 'C:\Users\usuario\Downloads'
        //    string caminhoSource = Path.Combine(caminhoUsuario, "source"); // Adiciona o caminho do usuário + 'source' (Pasta onde se localiza os projetos do Visual Studio) o que indica que ele pegárá o caminho de source 'C:\Users\usuario\source'
        //    string caminhoDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Pega o caminho do Desktop (Área de Trabalho) 'C:\Users\usuario\Área de Trabalho'

        //    //A aplicação (ou em especifico a pasta 'BD' localizada na aplicação) deve ser mantida em algum dessas pastas para funcionar o banco de dados (Downloads, Área de Trabalho ou source)
        //    //Pasta source só é utilizada para eu conseguir utilizar a aplicação no Visual Studio

        //    string[] pastas =
        //    [
        //        caminhoDownloads, caminhoDesktop, caminhoSource // Armazena as pastas em um array para procurar pelo arquivo futuramente
        //    ];

        //    foreach (string pastaEncontrada in pastas) // foreach = Em cada 'pastaEncontrada' em 'pastas' significa que o código passará por cada pasta encontrada
        //    {
        //        try
        //        {
        //            string[] arquivos = Directory.GetFiles(pastaEncontrada, nomeArquivo, SearchOption.AllDirectories) ; // Procura o arquivo nas pastas especificadas e subpastas


        //            if (arquivos.Length > 0) // Se encontrar o arquivo especifico
        //            {
        //                caminhoBanco = arquivos[0]; // Armazena o caminho do banco
        //                //MessageBox.Show(caminhoBanco, "Caminho do Banco", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mensagem para verificar se o caminho está correto
        //                break;  //Quebra o loop foreach
        //            }
        //        }
        //        catch (UnauthorizedAccessException erroNaoAutorizado)
        //        {
        //            MessageBox.Show(erroNaoAutorizado.Message, "Não há permissão para acessar essa pasta", MessageBoxButtons.OK, MessageBoxIcon.Information); // Caso a aplicação não tenha permissão para encontrar a pasta (Mostra a mensagem e continua a aplicação)
        //        }
        //        catch (Exception erroBug)
        //        {
        //            MessageBox.Show(erroBug.Message, "Erro ao encontrar o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information); // Se houver erro em encontrar as os arquivos
        //        }
        //    }
        //    return caminhoBanco; // Retorna o banco de dados por causa que o método exige uma saída de valor
        //}
    }
}

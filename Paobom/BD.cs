using System.Drawing.Drawing2D;

namespace Paobom
{
    public class BD
    {
        public static string caminhoBanco = ""; // Variável criada para indicar o caminho do banco (Onde está localizado o arquivo do banco de dados .mdf)
        public static string ProcurarArquivo(string nomeArquivo)
        {
            string caminhoUsuario = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); // Pega o caminho do usuário 'Exemplo : C:\Users\usuario'
            string caminhoDownloads = Path.Combine(caminhoUsuario, "Downloads"); // Adiciona o caminho do usuário + 'Downloads' o que indica que ele pegárá o caminho de Downloads 'C:\Users\usuario\Downloads'
            string caminhoSource = Path.Combine(caminhoUsuario, "source"); // Adiciona o caminho do usuário + 'source' (Pasta onde se localiza os projetos do Visual Studio) o que indica que ele pegárá o caminho de source 'C:\Users\usuario\source'
            string caminhoDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Pega o caminho do Desktop (Área de Trabalho) 'C:\Users\usuario\Área de Trabalho'

            //A aplicação (ou em especifico a pasta 'BD' localizada na aplicação) deve ser mantida em algum dessas pastas para funcionar o banco de dados (Downloads, Área de Trabalho ou source)

            string[] pastas =
            [
                caminhoDownloads, caminhoSource, caminhoDesktop // Armazena as pastas em um array para procurar pelo arquivo futuramente
            ];

            foreach (string pastaEncontrada in pastas)
            {
                try
                {
                    string[] arquivos = Directory.GetFiles(pastaEncontrada, nomeArquivo, SearchOption.AllDirectories); // Procura o arquivo nas pastas especificadas e subpastas

                    if (arquivos.Length > 0)
                    {

                        caminhoBanco = arquivos[0]; // Armazena o caminho do banco
                        //MessageBox.Show(caminhoBanco, "Caminho do Banco", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mensagem para verificar se o caminho está correto
                    }
                }
                catch (UnauthorizedAccessException erroNaoAutorizado)
                {
                    MessageBox.Show(erroNaoAutorizado.Message, "Não há permissão para acessar essa pasta", MessageBoxButtons.OK, MessageBoxIcon.Information); // Caso a aplicação não tenha permissão para encontrar a pasta (Mostra a mensagem e continua a aplicação)
                }
                catch (Exception erroBug)
                {
                    MessageBox.Show(erroBug.Message, "Erro ao encontrar o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Se houver erro em encontrar as os arquivos
                }
            }
            return null; // Retorna null por causa que o método exige uma saída de valor
        }

        public static string StringConexao
        {
            get //Obter a string
            {
                return $@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {caminhoBanco}; Integrated Security = True; Connect Timeout = 30"; // Utilizado para se conectar ao banco
            }
        }


    }
}

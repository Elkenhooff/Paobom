namespace Paobom
{
    public class BD
    {
        public static string caminhoBanco = "";
        public static string ProcurarArquivo(string nomeArquivo)
        {
            string[] pastas =
            {
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

        foreach (string pastaEncontrada in pastas)
            {
                string[] arquivos = Directory.GetFiles(pastaEncontrada, nomeArquivo, SearchOption.TopDirectoryOnly);

                if (arquivos.Length > 0)
                {
                    
                    caminhoBanco = arquivos[0];
                    MessageBox.Show(caminhoBanco, "Caminho do Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return null;
        }

        public static string StringConexao
        {
            get //Obter a string
            {
                return $@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {caminhoBanco}; Integrated Security = True; Connect Timeout = 30";
            }
        }
    }
}

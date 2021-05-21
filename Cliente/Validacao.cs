using System.Net;

namespace Cliente
{
    class Validacao
    {
        public Validacao(string enderecoIp, string nomeUsuario)
        {
            _enderecoIP = enderecoIp;
            _nomeUsuario = nomeUsuario;
        }

        private string _resultado;
        private string _enderecoIP;
        private string _nomeUsuario;

        public string ValidarDadosConexao()
        {
            _resultado = "";
            try
            {
                IPAddress.Parse(_enderecoIP);
            }
            catch
            {
                _resultado += "Endereço de IP inválido\r\n";
            }
            if (_nomeUsuario.Trim() == "" || _nomeUsuario.Trim() == "Nome de Usuário")
            {
                _resultado += "Insira um nome de Usuário";
            }
            else
            {
                try
                {
                    int.Parse(_nomeUsuario[0].ToString());
                    _resultado += "O nome de usuário não pode iniciar com um número";
                }
                catch { }
            }
            return _resultado;
        }
    }
}

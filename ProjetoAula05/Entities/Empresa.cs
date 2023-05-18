using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    /// <summary>
    /// Modelo de entidade para Empresa
    /// </summary>
    public class Empresa
    {
        #region Atributos

        private Guid _id;
        private string? _nomeFantasia;
        private string? _razaoSocial;
        private string? _cnpj;
        private List<Funcionario>? _funcionarios;

        #endregion

        #region Propriedades

        public Guid Id
        {
            get { return _id; }
            set 
            {
                if(value == Guid.Empty)
                    throw new ArgumentException("O Id da empresa não pode ser vazio.");

                _id = value; 
            }
        }

        public string NomeFantasia
        {
            get => _nomeFantasia;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O Nome Fantasia da empresa não pode ser vazio.");

                var regex = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{8,150}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Nome Fantasia inválido.");

                _nomeFantasia = value;
            }
        }

        public string RazaoSocial
        {
            get => _razaoSocial;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("A Razão Social da empresa não pode ser vazio.");

                var regex = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{8,150}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Nome Fantasia inválido.");

                _razaoSocial = value;
            }
        }

        public string Cnpj
        {
            get => _cnpj;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O CNPJ da empresa não pode ser vazio.");

                var regex = new Regex("^[0-9]{14}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("CNPJ inválido. Informe 14 dígitos numéricos.");

                _cnpj = value;
            }
        }

        public List<Funcionario> Funcionarios
        {
            get => _funcionarios;
            set
            {
                _funcionarios = value;
            }
        }
                
        #endregion
    }
}

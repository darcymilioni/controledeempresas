using ProjetoAula05.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    public class Funcionario
    {
        #region Atributos

        private Guid _id;
        private string? _nome;
        private string? _cpf;
        private string? _matricula;
        private DateTime? _dataAdmissao;
        private StatusFuncionario? _status;
        private Guid _idEmpresa;
        private Empresa? _empresa;

        #endregion

        #region Propriedades

        public Guid Id
        {
            get => _id;
            set
            {
                if(value == Guid.Empty) 
                    throw new ArgumentException("O Id do funcionário não pode ser vazio.");

                _id = value;
            }
        }

        public string? Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O nome do funcionário não pode ser vazio.");

                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{8,150}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Nome do funcionário é inválido.");
                
                _nome = value;
            }
        }

        public string Cpf
        {
            get => _cpf;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("O CPF do funcionário não pode ser vazio.");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("CPF inválido. Informe 11 dígitos numéricos.");

                _cpf = value;
            }
        }

        public string? Matricula
        {
            get => _matricula;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("A Matrícula do funcionário não pode ser vazio.");

                var regex = new Regex("^[0-9]{4,8}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Matrícula do funcionário inválida! Informe de 4 a 8 dígitos numéricos.");
                
                _matricula = value;
            }
        }

        public DateTime? DataAdmissao
        {
            get => _dataAdmissao;
            set
            {                               
                _dataAdmissao = value;
            }
        }

        public StatusFuncionario? Status
        {
            get => _status;
            set
            {
                _status = value;
            }
        }

        public Guid IdEmpresa
        {
            get => _idEmpresa;
            set
            {
                _idEmpresa = value;
            }
        }

        public Empresa? Empresa
        {
            get => _empresa; set
            {
                _empresa = value;
            }
        }

        #endregion
    }
}

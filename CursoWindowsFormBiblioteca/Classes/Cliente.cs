﻿using CursoWindowsFormBiblioteca.Databases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoWindowsFormBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do cliente é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do cliente somente aceita valores numéricos")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do cliente deve ter 6 dígitos")]
            public string Id { get; set; }
            [Required(ErrorMessage = "Nome do cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do cliente deve ter no máximo 50 caracteres")]
            public string Nome { get; set; }
            [Required(ErrorMessage = "Nome do mãe é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do mãe deve ter no máximo 50 caracteres")]
            public string NomeMae { get; set; }
            [StringLength(50, ErrorMessage = "Nome do pai deve ter no máximo 50 caracteres")]
            public string NomePai { get; set; }
            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "CPF é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos")]
            public string Cpf { get; set; }
            [Required(ErrorMessage = "Gênero é obrigatório")]
            public int Genero { get; set; }
            [Required(ErrorMessage = "CEP é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP somente aceita valores numéricos")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 dígitos")]
            public string Cep { get; set; }
            [Required(ErrorMessage = "Logradouro é obrigatório")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres")]
            public string Logradouro { get; set; }
            [Required(ErrorMessage = "Complemento é obrigatório")]
            [StringLength(100, ErrorMessage = "Complemento deve ter no máximo 100 caracteres")]
            public string Complemento { get; set; }
            [Required(ErrorMessage = "Bairro é obrigatório")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres")]
            public string Bairro { get; set; }
            [Required(ErrorMessage = "Cidade é obrigatório")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres")]
            public string Cidade { get; set; }
            [Required(ErrorMessage = "Estado é obrigatório")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres")]
            public string Estado { get; set; }
            [Required(ErrorMessage = "Número telefone é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Número telefone somente aceita valores numéricos")]
            public string Telefone { get; set; }
            public string Profissao { get; set; }
            [Required(ErrorMessage = "Renda familiar é obrigatório")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda familiar deve ser um valor positivo")]
            public double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do pai e da mãe não podem ser iguais");
                }
                if (this.NaoTemPai == false)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido não estiver marcada");
                    }
                }
                bool validaCPF = Cls_Uteis.Valida(this.Cpf);
                if (validaCPF == false)
                {
                    throw new Exception("CPF inválido");
                }
            }

            #region "CRUD do fichario"
            public void IncluirFichario(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario F = new Fichario(Conexao);
                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public Unit BuscarFichario(string Id, string conexao)
            {
                Fichario F = new Fichario(conexao);
                string clienteJson = F.Buscar(Id);
                if (F.status)
                {
                    return Cliente.DesSerializedClassUnit(clienteJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }

            }
            public void AlterarFichario(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    F.Alterar(this.Id, clienteJson);
                    if (!F.status)
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void ApagarFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    F.Apagar(this.Id);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public List<string> listaFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    List<string> todosJson = F.BuscarTodos();
                    return todosJson;
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            #endregion

            #region "CRUD do FicharioDB Local DB"

            public void IncluirFicharioDB(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioDB F = new FicharioDB(Conexao);
                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public Unit BuscarFicharioDB(string id, string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(id);
                    return Cliente.DesSerializedClassUnit(clienteJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFicharioDB(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    F.Alterar(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void ApagarFicharioDB(string conexao)
            {

                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    F.Apagar(this.Id);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }

            }

            public List<List<string>> BuscarFicharioDBTodosDB(string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    List<string> List = new List<string>();
                    List = F.BuscarTodos();
                    if (F.status)
                    {
                        List<List<string>> ListaBusca = new List<List<string>>();
                        for (int i = 0; i <= List.Count - 1; i++)
                        {
                            Cliente.Unit C = Cliente.DesSerializedClassUnit(List[i]);
                            ListaBusca.Add(new List<string> { C.Id, C.Nome });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            #endregion

        }
        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }
    }
}

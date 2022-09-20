using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Clinica
{
    class Medico{
        string certificadoCRM;
        string nome;
        string areaDeAtuacao;
        string email;
        int telefone;
        
        public Medico(string crm, string n, string atua, string e, int tel){
            certificadoCRM = crm;
            nome = n;
            areaDeAtuacao = atua;
            email = e;
            telefone = tel;
        }

        // Criando métodos GET
        public string GetCertificado(){
            return certificadoCRM;
        }

        public string GetNome(){
            return nome;
        }

        public string GetAtuacao(){
            return areaDeAtuacao;
        }

        public string GetEmail(){
            return email;
        }

        public int GetTelefone(){
            return telefone;
        }

        // Criando métodos SET
        public void SetCertificado(string crm){
            certificadoCRM = crm;
        }

        public void SetNome(string n){
            nome = n;
        }

        public void SetAtuacao(string atua){
            areaDeAtuacao = atua;
        }

        public void SetEmail(string e){
            email = e;
        }

        public void SetTelefone(int tel){
            telefone = tel;
        }
    }

    class Paciente{
        int cpf;
        string nome;
        short idade;
        char sexo;
        string tipoSanguineo;
        int telefone;
        string email;


        public Paciente(int c, string n, short i, char sex, string san, int tel, string e){
            cpf = c;
            nome = n;
            idade = i;
            sexo = sex;
            tipoSanguineo = san;
            telefone = tel;
            email = e;
        }

        // Criando métodos GET
        public int GetCpf(){
            return cpf;
        }

        public string GetNome(){
            return nome;
        }

        public short GetIdade(){
            return idade;
        }

        public char GetSexo(){
            return sexo;
        }

        public string GetTipoSanguineo(){
            return tipoSanguineo;
        }

        public int GetTelefone(){
            return telefone;
        }

        public string GetEmail(){
            return email;
        }

        // Criando métodos SET
        public void SetCpf(int c){
            cpf = c;
        }

        public void SetNome(string n){
            nome = n;
        }

        public void SetIdade(short i){
            idade = i;
        }

        public void SetSexo(char sex){
            sexo = sex;
        }

        public void SetTipoSanguineo(string san){
            tipoSanguineo = san;
        }

        public void SetTelefone(int tel){
            telefone = tel;
        }

        public void SetEmail(string e){
            email = e;
        }
    }

    class Atendimento{
        string crmMedico;
        int cpfPaciente;
        string data;
        string horario;
        string tipo;
        string status;
        Boolean foiPago;

        public Atendimento(string crm, int cpf, string d, string h, string t, string s, Boolean p){
            crmMedico = crm;
            cpfPaciente = cpf;                       
            data = d;
            horario = h;
            tipo = t;
            status = s;
            foiPago = p;
        }    
    }
}
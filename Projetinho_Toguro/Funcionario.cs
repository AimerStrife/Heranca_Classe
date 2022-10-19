// Classe Especialista / Classe Filha 

using System;

public class Funcionario : Pessoa 
{
    //atributos 
    private DateTime dataAdm;

    //Método Construtor 
    
    public void Funcionario_(int p_id, String p_nome, DateTime p_nasc, DateTime p_adm)
    {
        this.setId(p_id);
        this.setNome(p_nome);
        this.setDataNasc(p_nasc);
        this.setDataAdm(p_adm);
    }

    //Método
    public DateTime getDatAdm()
    {
        return this.dataAdm;
    }

    public void setDataAdm(DateTime p_adm)
    {
        this.dataAdm = p_adm;
    }

}
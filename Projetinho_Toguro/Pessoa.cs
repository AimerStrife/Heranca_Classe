using System;
//Aula Herança
public class Pessoa // Classe /Superclasse / Classe base 
{

    private int id;
    private String nome;
    private DateTime dataNasc;
   

    // Método - Get/Set Padrão \\

    public int getId()
    {
        return this.id;
    }

    public void setId(int p_Id)
    {
        this.id = p_Id;
    }




    public string getNome()
    {
        return this.nome;
    }
   
    public void setNome(string p_nome)
    {
        this.nome = p_nome;
    }




    public DateTime getDataNasc()
    {
        return this.dataNasc;
    }

    public void setDataNasc(DateTime p_dataN)
    {
        this.dataNasc = p_dataN;
    }





}


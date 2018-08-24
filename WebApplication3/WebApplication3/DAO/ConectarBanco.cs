using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication3.Modelos;

namespace WebApplication3.DAO
{
    public class ConectarBanco
    {
      private SqlConnection conexao = new SqlConnection("Contexto");
      private SqlCommand cmd;
      
      public List<Contato> ListaContato(){
            List<Contato> lista=new List<Contato>();
            Contato ctt =new Contato() ;
            try
            {
                conexao.Open();
                cmd = new SqlCommand("select * from  tb_contato");
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ctt.id = Convert.ToInt32(dr["id"]);
                    ctt.nome = dr["nome"].ToString();
                    ctt.fone = dr["fone"].ToString();
                    ctt.email = dr["email"].ToString();
                    lista.Add(ctt);

                }
                dr.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
      }
      public Boolean atualizarContato(Contato cct)
      {

          try
          {
              conexao.Open();
              cmd = new SqlCommand("update tb_contato set nome=@v1,fone=@v2,email=@v3 where id=@v4", conexao);
              cmd.Parameters.AddWithValue("@v1", cct.nome);
              cmd.Parameters.AddWithValue("@v2", cct.fone);
              cmd.Parameters.AddWithValue("@v3", cct.email);
              cmd.Parameters.AddWithValue("@v4", cct.id);
              cmd.ExecuteNonQuery();
              return true;


          }
          catch (Exception e)
          {
              return false;
          }
          finally
          {
              conexao.Close();
          }

      }

      public Boolean deleteContato(Contato cct)
      {

          try
          {
              conexao.Open();
              cmd = new SqlCommand("delete from tb_contato   where id=@v1", conexao);
              cmd.Parameters.AddWithValue("@v1", cct.id);
              cmd.ExecuteNonQuery(); 
              return true;


          }
          catch (Exception e)
          {
              return false;
          }
          finally
          {
              conexao.Close();
          }

      }

     

     public Boolean GravaContato(Contato cct)
      {

          try
          {
              conexao.Open();
              cmd = new SqlCommand("insert into tb_contato (nome,fone,email) values(@v1, @v2, @v3)", conexao);
              cmd.Parameters.AddWithValue("@v1", cct.nome);
              cmd.Parameters.AddWithValue("@v2", cct.fone);
              cmd.Parameters.AddWithValue("@v3", cct.email);
              cmd.ExecuteNonQuery(); 
              return true;


          }
          catch (Exception e)
          {
              return false;
          }
          finally
          {
              conexao.Close();
          }

      }

    }
   
}
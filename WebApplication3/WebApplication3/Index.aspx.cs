using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Modelos;
using WebApplication3.DAO;


namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConectarBanco dao = new ConectarBanco();
        Contato ctt = new Contato();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Contato> lista = new List<Contato>(dao.ListaContato());
            CarregaGrid(lista);
             gdvContato.Columns[0].Visible = false;
        }
        protected void CarregaGrid(List<Contato> lista){
            gdvContato.DataSource = lista;
            gdvContato.DataBind();
        }

        protected void gdvContato_RowEditing(object sender, GridViewCancelEditEventArgs e)
        {

        }
        protected void gdvContato_RowDeleting(object sender, GridViewCancelEditEventArgs e)
        {

        }
        protected void gdvContato_RowUpdating(object sender, GridViewCancelEditEventArgs e)
        {

        }
        protected void gdvContato_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
        
    

    }
}
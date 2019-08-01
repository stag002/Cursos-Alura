using MeuRoteiro.DAO;
using MeuRoteiro.Models;
using System;
using System.Net;
using System.Web.Mvc;

namespace MeuRoteiro.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Autentica(String email, String senha)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = dao.Busca(email, senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpGet]
        public ActionResult Adiciona(string nome, string email, string senha)
        {
            UsuariosDAO dao = new UsuariosDAO();

            Usuario usuario = new Usuario();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;

            dao.Adiciona(usuario);

            return new HttpStatusCodeResult(HttpStatusCode.OK, "Novo usuário tem o ID:" + usuario.Id );
        }
    }
}
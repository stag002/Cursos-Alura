﻿using MeuRoteiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuRoteiro.DAO
{
    public class UsuariosDAO
    {
        public void Adiciona(Usuario usuario)
        {
            using (var context = new UsuarioContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }
        public IList<Usuario> Lista()
        {
            using (var contexto = new UsuarioContext())
            {
                return contexto.Usuarios.ToList();
            }
        }
        public Usuario BuscaPorId(int id)
        {
            using (var contexto = new UsuarioContext())
            {
                return contexto.Usuarios.Find(id);
            }
        }
        public void Atualiza(Usuario usuario)
        {
            using (var contexto = new UsuarioContext())
            {
                contexto.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public Usuario Busca(string login, string senha)
        {
            using (var contexto = new UsuarioContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }
    }
}
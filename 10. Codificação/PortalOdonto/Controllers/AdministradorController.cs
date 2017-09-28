﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;
using Model.Models.Exceptions;
namespace PortalOdonto.Controllers
{
    public class AdministradorController : Controller
    {
        
        private GerenciadorUsuario usuarioGerenciador;
        // GET: Usuario
        public AdministradorController()
        {           
            usuarioGerenciador = new GerenciadorUsuario();
        }
        public ActionResult Index()
        {
            List<Usuario> usuarios = usuarioGerenciador.ObterTodos();
            if (usuarios == null || usuarios.Count == 0)
                usuarios = null;
            return View(usuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details (int? id)
        {
            if (id.HasValue)
            {
                Usuario user = usuarioGerenciador.Obter(id);
                if (user != null)
                    return View(user);
            }
            return RedirectToAction("Index");
        }       

        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection dadosForm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Usuario u = new Usuario();
                    
                    int tipo = Convert.ToInt32(dadosForm["TipoUsuario"]);
                    tipo--;
                    switch (tipo)
                    {
                        case ((int) TipoUsuario.PROFESSOR):                            
                             Professor p = new Professor();
                             TryUpdateModel<Professor>(p, dadosForm.ToValueProvider());
                             TryUpdateModel<Usuario>(u, dadosForm.ToValueProvider());
                             usuarioGerenciador.Adicionar(u);
                             break;
                        case ((int)TipoUsuario.ALUNO):
                            Aluno a = new Aluno();
                            TryUpdateModel<Aluno>(a, dadosForm.ToValueProvider());
                            TryUpdateModel<Usuario>(u, dadosForm.ToValueProvider());
                            usuarioGerenciador.Adicionar(u);
                            break;
                        case ((int)TipoUsuario.TECNICO):
                            Tecnico t = new Tecnico();
                            TryUpdateModel<Tecnico>(t, dadosForm.ToValueProvider());
                            TryUpdateModel<Usuario>(u, dadosForm.ToValueProvider());
                            usuarioGerenciador.Adicionar(u);
                            break;                                                                         
                    }                    
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch (NegocioException e)
            {
                throw new ControllerException("Não foi possivél completar a acão", e);
            }
            catch (Exception e)
            {
                throw new NegocioException("Não foi possivél completar a acão", e);
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Usuario user = usuarioGerenciador.Obter(id);
                if (user!= null)
                    return View(user);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Edit(int id, Usuario user)
        {
            try
            {
                usuarioGerenciador.Editar(user);
                return RedirectToAction("Index");
                
            }
            catch (NegocioException e)
            {
                throw new ControllerException("Não foi possivél completar a acão", e);
            }
            catch (Exception e)
            {
                throw new NegocioException("Não foi possivél completar a acão", e);
            }
        }


        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                Usuario user = usuarioGerenciador.Obter(id);
                if (user!= null)
                    return View(user);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Usuario user)
        {
            try
            {
                usuarioGerenciador.Remover(usuarioGerenciador.Obter(id));
                return RedirectToAction("Index");
            }
            catch (NegocioException e)
            {
                throw new ControllerException("Não foi possivél completar a acão", e);
            }
            catch (Exception e)
            {
                throw new NegocioException("Não foi possivél completar a acão", e);
            }

        }

        [HttpPost]
        public ActionResult Buscar(int? matricula)
        {
            List<Usuario> usuarios = usuarioGerenciador.Buscar(matricula);
            if (usuarios == null)
                usuarios = null;

            return View("Index", usuarios);
        }
    }
}

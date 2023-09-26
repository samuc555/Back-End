using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


//? Criando a classe TarefaController e herndando seus métodos de Controller
public class TarefaController : Controller
{
    //? Criando um objeto _tarefas que armazenará uma lista de tarefas
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_tarefas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        //? Verificando o total de tarefas da lista e somando mais uma para criar o ID
        novaTarefa.Id = _tarefas.Count + 1;
        //? Adicionando minhanova tarefa à minha lista
        _tarefas.Add(novaTarefa);
        //? Redirecionando para a página principal com a lista de tarefas
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int id)
    {
        //? Estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        //? Verificando se ela existe
        if (novaTarefa == null)
            return NotFound();

        //? Enviando para a View a tarefa que queremos alterar
        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditando)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
        if (tarefaEncontrada == null)
            return NotFound();

        tarefaEncontrada.Descricao = tarefaEditando.Descricao;
        tarefaEncontrada.Concluida = tarefaEditando.Concluida;
        return RedirectToAction("Index");
    }

    public IActionResult Deletar(int id)
    {
        //? Estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        //? Verificando se ela existe
        if (novaTarefa == null)
            return NotFound();

        //? Enviando para a View a tarefa que queremos alterar
        return View(novaTarefa);
    }

    [HttpPost]                                                                                                      
    public IActionResult DeletarConfirmado(int Id)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (tarefaEncontrada == null)
            return NotFound();

        _tarefas.Remove(tarefaEncontrada);
        return RedirectToAction("Index");
    }
}
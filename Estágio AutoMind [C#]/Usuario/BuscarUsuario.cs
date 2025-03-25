namespace EstagioAutomind.Usuario;

public class BuscarUsuario {
	/* Método para buscar usuário na lista a partir do nome */
	public static void buscar(List<CadastroUsuario> usuario) {
		try {
			if (usuario.Count == 0)
				throw new Exception("A lista está vazia, a seção cadastrado será acessada.");
			
			Console.Write("\nDigite o nome do usuário que deseja buscar: ");
			string nome = Console.ReadLine().Trim().ToLower();
			/* ToLower() -> Transforma todos os caracteres da expressão (argumento) em letra minúscula
			   Trim() -> Remove caracteres especificados do lado que houver (esquerdo ou direito) */
			
			/* Operação lambda para busca na lista */
			var usuariosEncontrados =
				usuario.Where(u => u.Nome.Trim().ToLower().Contains(nome)).ToList();
			/* Contains(nome) -> Busca o nome mesmo se houver somente partes dele */
			
			bool encontrado = false; /* Booleano para visualizar situação da busca */
			
			foreach (var u in usuariosEncontrados) {
				if (usuariosEncontrados.Any()) {
					Console.WriteLine();
					Console.WriteLine($"Nome: {u.Nome}");
					Console.WriteLine($"Email: {u.Email}");
					Console.WriteLine($"Idade: {u.Idade}");
					encontrado = true;
				} 
			}
			
			if (!encontrado) { Console.WriteLine("Usuário inexistente!"); }
		} catch (Exception e) {
			/* Capturamos o erro caso a lista esteja vazia */
			Console.WriteLine($"Erro: {e.Message}");
			
			/* Em caso de lista vazia, seção de cadastro é chamada automaticamente */
			CadastroUsuario.Cadastro(usuario);
		}
	}
}

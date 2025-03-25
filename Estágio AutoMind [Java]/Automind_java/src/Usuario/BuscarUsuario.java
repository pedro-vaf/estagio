package Usuario;

import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class BuscarUsuario {
    public static void buscar(List<CadastroUsuario> usuarios, Scanner sc) {
        try {
            if (usuarios.isEmpty())
                throw new Exception("Lista vazia, seção cadastro será acessada automaticamente!");

            System.out.print("Digite o nome completo ou parte do que deseja buscar: ");
            String nome = sc.nextLine().trim().toLowerCase();

            List<CadastroUsuario> usuarioEncontrado =
                  usuarios.stream().filter(u -> u.getNome().toLowerCase().contains(nome)).toList();

            boolean encontrado = false;
            for (CadastroUsuario u : usuarioEncontrado) {
                System.out.println();
                System.out.println("Nome: " + u.nome);
                System.out.println("Email: " + u.email);
                System.out.println("Idade: " + u.idade);
                encontrado = true;
            }

            if (!encontrado) { System.out.println("Usuário não existente!"); }

        } catch (Exception e) {
            System.out.println(e.getMessage());
            CadastroUsuario.cadastro(usuarios, sc);
        }
    }
}

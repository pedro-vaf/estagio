package Usuario;

import java.util.List;
import java.util.Scanner;

public class ListarUsuario {
    public static void listar(List<CadastroUsuario> usarios, Scanner sc){
        try {
            if (usarios.isEmpty())
                throw new Exception("Lista vazia, seção cadastro será acessada automaticamente!");

            for (CadastroUsuario u : usarios) {
                System.out.println();
                System.out.println("Nome: " + u.nome);
                System.out.println("Email: " + u.email);
                System.out.println("Idade: " + u.idade);
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
            CadastroUsuario.cadastro(usarios, sc);
        }
    }
}

package Application;

import Usuario.BuscarUsuario;
import Usuario.CadastroUsuario;
import Usuario.ListarUsuario;
import Usuario.Menu;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        List<CadastroUsuario> usuarios = new ArrayList<CadastroUsuario>();

        int opcaoMenu = -1;

        do {
            opcaoMenu = Menu.menu(sc);

            switch (opcaoMenu){
                case 0:
                    System.out.println("Encerrando programa...");
                break;

                case 1:
                    CadastroUsuario.cadastro(usuarios, sc);
                break;

                case 2:
                    ListarUsuario.listar(usuarios, sc);
                break;

                case 3:
                    BuscarUsuario.buscar(usuarios, sc);
                break;

                default:
                    System.out.println("Opção inválida!");
                break;

            }

        } while (opcaoMenu != 0);

        sc.close();
    }
}
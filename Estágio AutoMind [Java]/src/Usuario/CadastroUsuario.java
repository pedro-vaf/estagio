package Usuario;

import java.util.List;
import java.util.Scanner;

public class CadastroUsuario {
    public String nome;
    public String email;
    public Integer idade;

    public CadastroUsuario(String nome, String email, Integer idade) {
        this.nome = nome;
        this.email = email;
        this.idade = idade;
    }

    public String getNome() {
        return nome;
    }

    public String getEmail() {
        return email;
    }

    public Integer getIdade() {
        return idade;
    }

    public static void cadastro(List<CadastroUsuario> usuarios, Scanner sc){
        int opcao = -1, entradaOpcao;
        int idade = -1, entradaIdade;



        do {
            boolean validador = false;
            boolean validador_2 = false;

            System.out.println();
            System.out.println("*** Seção cadastro ***");
            System.out.print("Insira o nome do usuário: ");
            String nome = sc.nextLine();
            System.out.print("Insira o email do usuário: ");
            String email = sc.nextLine();

            while (!validador) {
                System.out.print("Insira a idade: ");
                String entrada = sc.nextLine();

                try {
                    entradaIdade = Integer.parseInt(entrada);
                    if (entradaIdade > 0){
                        validador = true;
                        idade = entradaIdade;

                        CadastroUsuario dadoUsuario = new CadastroUsuario(nome, email, idade);
                        usuarios.add(dadoUsuario);

                    } else { System.out.println("Insira uma idade válida!"); }
                } catch (NumberFormatException e) {
                    System.out.println("Só é permitido número inteiro");
                }
            }

            while (!validador_2) {
                System.out.print("\nDeseja cadastrar um novo usuário? [1 sim | 2 não]: ");
                String entrada_2 = sc.nextLine();

                try {
                    entradaOpcao = Integer.parseInt(entrada_2);
                    if (entradaOpcao >= 1 && entradaOpcao <= 2) {
                        validador_2 = true;
                        opcao = entradaOpcao;
                    } else { System.out.println("\nErro! Insira 1 para sim e 2 para não."); }
                } catch (NumberFormatException e) {
                    System.out.println("\nErro! só é permitido inteiro - Insira 1 para sim e 2 para não.");
                }
            }
        } while (opcao == 1);

    }
}

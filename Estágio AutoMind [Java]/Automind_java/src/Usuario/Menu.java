package Usuario;

import java.util.Scanner;

public class Menu {
    public static int menu(Scanner sc){

        int opcao = -1, temp;
        boolean validador = false;

        while (!validador) {
            System.out.println("*** Menu ***");
            System.out.println("0. Sair");
            System.out.println("1. Cadastrar usuário");
            System.out.println("2. Listar usuário");
            System.out.println("3. Buscar usuário");
            System.out.print("Insira alguma opção para continuar: ");
            String entrada = sc.nextLine();

            try {
                /* Verificar se a entrada recebida foi um inteiro */
                temp = Integer.parseInt(entrada);
                /* Verificar se o número está dentro do intervalo permitido */
                if (temp >= 0 && temp <= 3) {
                    opcao = temp;
                    validador = true;
                } else {
                    System.out.println("ERRO! Insira um valor entre 0 e 3!");
                }
            } catch (NumberFormatException e) {
                System.out.println("Erro: Entrada inválida, só é permitido número inteiro");
            }
        }

        return opcao;
    }

}

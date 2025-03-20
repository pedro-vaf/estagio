/*
Descrição do Problema:
A sequência X é formada da seguinte maneira: cada termo, a partir do quarto, é a soma do penúltimo e do antepenúltimo termo.
Por exemplo, em uma sequência que começa com 5, 6, 8, os 10 primeiros termos são: 5, 6, 8, 11, 14, 19, 25, 33, 44, 58.
Sua tarefa: Considerando essa sequência começando por 5, 6, 8, calcule e imprima o valor do quinquagésimo termo (50º termo).
*/

function sequenciaX (antepenultimo, penultimo, atual, aux) {
    if (aux === 50) {
        console.log(`O quinguagésimo termo é: ${atual}`);
        return;
    }
    sequenciaX(penultimo, atual, penultimo + antepenultimo, aux + 1);
}

sequenciaX(5, 6, 8, 3);


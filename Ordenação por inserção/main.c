#include <stdio.h>
#include <stdlib.h>
const tam = 10;

int main()
{
    void ordenar(int vetor[]);
    int num[tam];

        for(int i = 0; i<tam; i++)
        {
            printf("Digite um valor: ");
            scanf("%d", &num[i]);
            system("cls");
        }
        for(int k = 0; k<tam; k++)
                printf(" %d ", num[k]);

        printf("\n\nApos a ordenacao por insercao\n\n");

       ordenar(num);



    return 0;
}

/*
void ordena(int num[])
{
     int min, aux, aux2;
    for (int i = 0; i < (tam-1); i++)
    {
        min = i;
        for (int j = (i+1); j < tam; j++)
        {
            if(num[j] < num[min])
            min = j;
        }
        if (num[i] != num[min])
        {
            aux = num[i];
            for(int ordenar=tam; ordenar>i; ordenar--){
                aux2 = num[i];
                num[i-1] = num[i];
            }
            num[i] = aux;

        }
    }
    for(int s=0; s<tam; s++)
        printf(" %d " ,num[s]);

    printf("\n");
}
*/
void ordenar(int vetor[])
{
    for (int i = 1; i < tam; i++)
    {
        int aux = vetor[i];
        int j = i-1;

        while (j >= 0 && vetor[j] > aux)
        {
            vetor[j+1] = vetor[j];
            j -= 1;
        }
        vetor[j+ 1] = aux;
    }
    for(int ordem=0; ordem<tam; ordem++)
        printf(" %d ", vetor[ordem]);
}

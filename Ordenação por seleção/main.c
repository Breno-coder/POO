#include <stdio.h>
#include <stdlib.h>
const tam = 10;

int main()
{
    void ordena(int num[]);
    int num[tam];

        for(int i = 0; i<tam; i++)
        {
            printf("Digite um valor: ");
            scanf("%d", &num[i]);
            system("cls");
        }
        for(int k = 0; k<tam; k++)
                printf(" %d ", num[k]);

        printf("\n\nApos a ordenacao por selecao\n\n");

       ordena(num);



    return 0;
}


void ordena(int num[])
{
     int min, aux;
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
            num[i] = num[min];
            num[min] = aux;
        }
    }
    for(int s=0; s<tam; s++)
        printf(" %d " ,num[s]);

    printf("\n");
}

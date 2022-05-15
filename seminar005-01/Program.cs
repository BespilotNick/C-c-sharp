//

int[] ChangeNums(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= (-1);

    return array;
}
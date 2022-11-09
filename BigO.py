import array as arr
import collections

def hw1(num1,num2):
    if(num1 > num2): return 1       #O(1)
    elif(num1 == num2): return 0    #O(1)
    else: return -1                 #O(1)
    # O(1) + O(1) + O(1) -> O(1)

def hw2(array):
    mid = len(array)/2                  #O(1)
    list =[]                            #O(1)
    if(len(array)%2 != 0):              #O(1)
        list.append(array[int(mid)])    #O(1)
    else:
        list.append(array[int(mid-1)])  #O(1)
        list.append(array[int(mid)])    #O(1)
    return list                         #O(1)
    # O(1) + O(1) + O(1)+ O(1) + O(1) +O(1) +O(1) -> O(1)


def hw3(array):
    max = array[1]                              #O(1)
    for i in range(len(array)):                 #O(n)
        if(array[i]>max):                       #O(1)
            max = array[i]                      #O(1)
    return max                                  #O(1)
    # O(1) + O(n)*2O(1) + O(1) -> O(n)

def hw4(array):
    dict = {}                                               #O(1)
    for i in range(len(array)):                             #O(n)
        if(array[i] not in dict):                           #O(1)
            dict[array[i]] = 1                              #O(1)
        else:
            dict[array[i]] += 1                             #O(1)
    return collections.OrderedDict(sorted(dict.items()))    #O(1)
    #O(1) + O(n)* 3O(1) +O(1) -> O(n)

def hw5(array1,array2):
    shared = []                                                         #O(1)
    for i in range(len(array1)):                                        #O(n)
        for j in range(len(array2)):                                    #O(n)
            if(array1[i]  == array2[j] and array1[i] not in shared):    #O(1)
                shared.append(array2[j])                                #O(1)
    return shared                                                       #O(1)
    #O(1) + O(n)*O(n)*2O(1) + O(1) -> O(n^2)

def hw6(num,array):
    count = 0                       #O(1)
    index = []                      #O(1)
    for i in range(len(array)):     #O(n)
        if(num == array[i]):        #O(1)
            index.append(i)         #O(1)
            count += 1              #O(1)
    if(count == 0):                 #O(1)
        return None                 #O(1)
    return index                    #O(1)
    #O(1) + O(1) + O(n)* 3O(1)+ O(1) + O(1) + O(1) -> O(n)

def main():
    a = arr.array("i",[9,10,4,2,1,20,3,144,2,1,9,1,1])
    b = arr.array("i",[1,9,2,3,10])
    print("Result hw1: ",hw1(1,2))
    print("\nResult hw2: ",hw2(a))
    print("\nResult hw3: ",hw3(a))
    print("\nResult hw4: ",hw4(a))
    print("\nResult hw5: ",hw5(a,b))
    print("\nResult hw6: ",hw6(0,b))

if __name__ == "__main__":
    main()
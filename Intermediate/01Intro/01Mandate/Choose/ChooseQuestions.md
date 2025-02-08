## Q3. Find Iterations
### Find the number of times below code runs where N is a perfect square
	for i -> 1 to N
	if(i * i == N)
	return i
### Options
	A) N
	B) N/2
	C) sqrt(N)
	D) logN
### Answer
	C) sqrt(N)

## Q4. Sum of N natural numbers
### The sum of n natural numbers is :
### Options
	A) (n*(n+1))/2
	B) (n*(n-1))/2
	C) (n+1)/2
	D) (n(n+1)(2*n+1))/6
### Answer
	A) (n*(n+1))/2

## Q5. Find Number of Iterations - 3
### How many iterations will take place?

```
int func(int n){
    int s = 0;
    for(int i = 1 ; i <= 100 ; i++){ 
        s = s + i;
    }
    return s;
}
```
### Options
	A) 100	
	B) 99
	C) 98
	D) 101
### Answer
	A) 100

## Q6. Find Number of Iterations - i
### Find the number of iterations in the following code snippet:

```
int ans = 0;
for (int i = 0; i < n; i++)
{
    ans += i * i;
}
```
### Options
	A) n^2
	B) n
	C) n-1
	D) n+1
### Answer
	B) n

## Q7. Find Number of Iterations - 7
### What will be the total number of iterations in the following code?

```
for (int i = 0; i < n; i++) {
    for (int j = 0; j <= i; j++) {
        print(i + j);
    }
}
```
### Options
	A) n^2
	B) n
	C) n-1
	D) n+1
### Answer
	B) n

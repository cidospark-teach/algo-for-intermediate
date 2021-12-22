# LaundryMachine

We will like to pick socks for laundry in such a way that after washing we will have a maximal number of clean, same-coloured pair of socks. It is possible that some socks cannot be paired with any other socks, because we may have lost socks over the years.

This machine can only wash a sock at a time and clean at most 'n' number of  socks as described by `noOfWashes`.

---

There are two category of socks which are described as `cleanPile` and `dirtyPile` respectively. The colours of the socks are represented as integers with _equal numbers_ representing identical colours.

For example, if the laundry machine can clean at most 2 socks.

```
noOfWashes: int number = 2;
cleanPile: int[] number = new int[] {1, 2, 1, 1};
dirtyPile: int[] number = new int[] {1, 4, 3, 2, 4};
```

Then, the maximum number of pairs of socks is 3.

If `noOfWashes` is 0. The maximum number of socks is 1 because the machine will only select matching clean pair of socks from the `cleanPile`.

Also, if the machine can wash as many socks as we want, the maximum number of pair of socks, for this scenario is 4.

Note that clean socks do not need to be washed again so the `noOfWashes` will only count whenever the `dirtyPile` is used to get matching clean pairs.

---

Write a function that given the `noOfWashes`, `cleanPile`, and `dirtyPile` returns the maximum number of pair of socks based on the given conditions.

Assume that

`noOfWashes` is an integer within the range `0...50`
`cleanPile` and `dirtyPile` is an integer array within the range `1...50`, they cannot be empty, and contain at most 50 elements.


## Get Started with this app.

### On Windows using Visual studio IDE

Clone this repo and run the solution file, Preferably using visual studio 2019. Simply by clicking the soliution file in the package named ('LaundryMachine.sln'). Visual studio IDE will open the solution file, and the internal server IIS will open it in your default browser

### On Windows Or Linux using VSCODE or (Other editor of choice)

Clone this repo and

Change directory to the root folder 'LaundryMachine'. Open the folder containting the solution file in VSCode text editor (Preferably) or other text editor of choice. Execute a build command ('dotnet build') to resolve any dependencies. Execute the run command ('dotnet run')

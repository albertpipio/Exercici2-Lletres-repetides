// Fase 1

var name = ["a", "l", "b", "e", "r", "t"];

for (i = 0; i < name.length; i++)
{
  console.log(name[i]);
};

//Fi Fase 1

//Fase 2

var listName = ["a", "l", "b", "e", "r", "t"];

listName.forEach((name) =>
{
  switch (name)
  {
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":

    console.log("Vocal");
    break;

    case "1":
    case "2":
    case "3":
    case "4":
    case "5":
    case "6":
    case "7":
    case "8":
    case "9":

    console.log("Els noms de persones no contenen números!");
    break;

    default:

    console.log("Consonant");
  }
});

//Fi Fase 2

//Fase 3

var dictionary = {};

for (var letter in listName)
{
  if (!dictionary.ContainsKey(letter))
  {
      dictionary.push(letter, 1);
  }

  else
  {
    dictionary[letter]++;
  }
};

dictionary.forEach (letter in dictionary)
{
  console.log(letter);
}

//Fi fase 3

//Fase 4

var surname = ["p", "i", "p", "i", "ó"];
var surnameList = ["p", "i", "p", "i", "ó"];
var fullName = [];

for (i = 0; i < name.length; i++)
{
  listName.push(name[i]);
}

for (i = 0; i < surname.length; i++)
{
  surnameList.push(surname[i]);
}

fullName.addRange(listName);
fullName.addRange(" ");
fullName.addRange(surnameList);

fullName.forEach(element => console.log(element));

//Fi Fase 4
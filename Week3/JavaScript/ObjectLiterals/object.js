
let car = {
    make: 'bmw',
    model: '745li',
    year: 2010,
    getPrice: function() {
        // perform some calc
        return 5000;
    },
    printDescription: function() {
        console.log(this.make + ' ' + this.model);
    }
}

car.printDescription();
console.log(car.year);

// console.log(car['year']);
// console.log(car[1]);

/*
var anotherCar = {};
anotherCar.whatever = 'bob';
console.log(anotherCar.whatever);
*/

/*
var a = {
    myProperty: { b: 'hi' }
};
console.log(a.myProperty.b);
*/

/*
var c = {
    myProperty: [
        { d: 'this' },
        { e: 'can' },
        { f: 'get' },
        { g: 'crazy' }
    ]
};
*/

let carLot = [
    { year: 2017, make: 'Toyota', model: '4Runner' },
    { year: 2015, make: 'BMW', model: '528i' },
    { year: 1982, make: 'Buick', model: 'Skylark' },
];

let contacts = {
    customers: [
        { firstName: 'Bob', lastName: 'Tabor', phoneNumbers: [ '(123) 456-7890', '(123) 567-8901' ] },
        { firstName: 'Richard', lastName: 'Boughton', phoneNumbers: [ '(123) 555-7894', '(123) 555-8903' ] }
    ],
    employees: [
        { firstName: 'Steve', lastName: 'Jaworski', phoneNumbers: [ '(312) 456-7890', '(312) 567-8901' ] },
        { firstName: 'Conrad', lastName: 'Tabor', phoneNumbers: [ '(312) 456-7890' ] },
        { firstName: 'Grant', lastName: 'Tabor', phoneNumbers: [ '(312) 456-7890' ] },
    ]
};

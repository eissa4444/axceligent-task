function subtract(number: number) {
    return function (target, propertyKey: string, descriptor: PropertyDescriptor) {
        descriptor.value = number - 1;
    }
}


function multiply(number: number) {
    return function (target, propertyKey: string, descriptor: PropertyDescriptor) {
        descriptor.value *= number;
    }
}

class MathClass {

    @subtract(1)
    @multiply(2)
    addOne(number: number) {
        return number + 1;
    }
}

console.log(new MathClass().addOne(2)) //should print 5

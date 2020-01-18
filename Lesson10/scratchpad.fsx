
type Address =
    { Street: string
      Town: string
      City: string }

type Customer =
    { Forename: string
      Surname: string
      Age: int
      Address: Address
      EmailAddress: string }

let customer =
    { Forename = "Joe"
      Surname = "Bloggs"
      Age = 30
      Address =
        { Street = "The Street"
          Town = "The Town"
          City = "The City" }
      EmailAddress = "joe@bloggs.com" }
      
let updatedCustomer =
    { customer with
        Age = 31
        EmailAddress = "joe@bloggs.co.uk" }

let address1 =
    { Street = "Street"
      Town = "Town"
      City = "City" }

let address2 =
    { Street = "Street"
      Town = "Town"
      City = "City" }

address1 = address2

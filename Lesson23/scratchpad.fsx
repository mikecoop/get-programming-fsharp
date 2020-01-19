
type CustomerId = CustomerId of string

type ContactDetails =
| Address of string
| Telephone of string
| Email of string

type Customer =
    { CustomerId: CustomerId
      PrimaryContactDetails: ContactDetails
      SecondaryContactDetails: ContactDetails option }

type GeniuineCustomer = GenuineCustomer of Customer

let createCustomer customerId primary secondary =
    { CustomerId = customerId
      PrimaryContactDetails = primary
      SecondaryContactDetails = secondary }

let validateCustomer customer =
    match customer.PrimaryContactDetails with
    | Email e when e.EndsWith "SuperCorp.com" -> Some (GenuineCustomer customer)
    | Address _ | Telephone _ -> Some (GenuineCustomer customer)
    | Email _ -> None

let sendWelcomeEmail (GenuineCustomer customer) =
    printfn "Hello, %A, and welcome to our site!" customer.CustomerId

let customer =
    createCustomer
        (CustomerId "C-123")
        (Email "nicki@myemail.com")

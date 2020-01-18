namespace Lesson14.Domain

open System

type Customer =
    { Name: string }

type Account =
    { Owner: Customer
      Balance: decimal
      AccountId: Guid }

module BrokenRomanNumbers


open System.Collections.Generic

let larger_number_after (i:int)  (ch:char)  (str:string) =
    let mutable numerals = new Dictionary<char,int>()
    ['M', 1000; 'D', 500; 'C', 100; 'L', 50; 'X', 10; 'V', 5; 'I', 1] |> Seq.iter numerals.Add
    let mutable success = false
    for i in [i .. str.Length-2] do
        if numerals.[str.[i+1]] > numerals.[ch] then
            success <- true
    success

let check_separation (str:string) =
    let numerals = [('I', 1); ('V', 5); ('X', 10); ('L', 50); ('C', 100); ('D', 500); ('M', 1000)]
    let mutable idx = new Dictionary<char,int>()
    ['I', 0; 'V', 1; 'X', 2; 'L', 3; 'C', 4; 'D', 5; 'M', 6] |> Seq.iter idx.Add
    let mutable success = false
    for i in [0 .. str.Length-2] do
        let ch = str.Chars(i)
        if i < str.Length-2 then
            if (str.[i+1] = ch && (larger_number_after (i+1) ch str)) then
                success <- true
            for j in [idx.[ch]+1 .. numerals.Length-1] do
                if i < str.Length-1 && ch <> 'I' then
                    if str.[i+1] = 'M' && str.[i] = 'C' or 
                       str.[i+1] = 'X' && str.[i] = 'C' or 
                       str.[i+1] = 'L' && str.[i] = 'X' then
                       ()
                    elif str.[i+1] = fst numerals.[j] then
                       success <- true               
    success

(*
    A smaller number in front of a larger number means subtraction, all else means addition.
    For example, IV means 4, VI means 6.

    You would not put more than one smaller number in front of a larger number to subtract.
    For example, IIV would not mean 3.

    You must separate ones, tens, hundreds, and thousands as separate items.
    That means that 99 is XCIX, 90 + 9, but never should be written as IC. 
    Similarly, 999 cannot be IM and 1999 cannot be MIM.

    Author: Steve Fortuneseeker
    
*)
let convert(input:string)=
        if input.GetType().Equals(string) then
            if (input.Replace("M", "").Replace("D", "").Replace("C", "").Replace("L", "").Replace("X", "").Replace("V", "").Replace("I", "")).Length > 0 then
               failwith "invalid input"
        let sum = 0
        if (input.IndexOf("IIIII") > -1) or input.IndexOf("VV") > -1 or input.IndexOf("XXXXX") > -1 or
          input.IndexOf("DD") > -1 or input.IndexOf("CCCCC") > -1 then
            failwith "invalid input"
        if input.IndexOf("IIV") > -1 or input.IndexOf("IIX") > -1 or input.IndexOf("IL") > -1 or 
           input.IndexOf("IC") > -1 or input.IndexOf("ID") < -1 or input.IndexOf("IM") > -1 or
           (check_separation input ) then
             failwith "invalid input"
        let mutable sum=0
        for i in [0 .. input.Length-1] do
            let ch = input.Chars(i)
            if ch = 'M' then
                if larger_number_after i  ch input then
                    sum <- sum - 1000
                else
                    sum <- sum + 1000
            elif ch = 'D'then
                if larger_number_after i ch input then
                    sum <- sum - 500
                else
                    sum <- sum + 500
            elif ch = 'C' then
                if larger_number_after i  ch input then
                    sum <- 100 - sum
                else 
                    sum <- sum + 100
            elif ch = 'L' then
                if larger_number_after i ch input then
                    sum <- sum - 50
                else 
                    sum <- sum + 50
            elif ch = 'X' then
                if larger_number_after i ch input then
                    sum <- sum - 10
                else
                    sum <- sum + 10
            elif ch = 'V' then
                if larger_number_after i ch input then
                    sum <- sum - 5
                else
                    sum <- sum + 5
            elif ch = 'I' then
                if larger_number_after i ch input then
                    sum <- sum - 1
                else 
                    sum <- sum + 1
        sum
    



     


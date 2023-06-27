Code for an activity proposed by the C# course on the udemy.com website.  

A company wants to automate the processing of its contracts. The processing of a contract consists of generating the installments to be paid for that contract, based on the desired number of months.  
The company uses an online payment service to pay installments. Online payment services typically charge a monthly interest as well as a fee. by payment. For now, the service contracted by the company is Paypal, which applies 1% simple interest on each installment, plus a 2% payment fee.  
Write a program to read contract data (contract number, contract date, and total value of the contract). Then the program should read the number of months to installment of the contract, and then generate the records of installments to be paid (date and value), the first installment to be paid one month after the contract date, the second installment two months after the contract and so on. Show parcel data on screen.  
See example below.  

Enter contract data  
Number: **8028**  
Date (dd/MM/yyyy): **25/06/2018**  
Contract value: **600.00**  
Enter number of installments: *3*  
Installments:  
25/07/2018 - 206.04  
25/08/2018 - 208.08  
25/09/2018 - 210.12  

---------------------------------
*Calculations (1% monthly simple interest + 2% payment fee):*  
*Quota #1:*  
*200 + 1% \ * 1 = 202*  
*202 + 2% = 206.04*  

*Quota #2:*  
*200 + 1% \ * 2 = 204*  
*204 + 2% = 208.08*  

*Quota #3:*  
*200 + 1% \ * 3 = 206*  
*206 + 2% = 210.12*  
- Web services are used objects are separated. A object(Document Info) for all document types was used. Each document consists of different object types are derived from each other in this version. Details for objects used : https://github.com/huginsdk/tps-v3/wiki/WS-Objects

- The new document types are added. (https://github.com/huginsdk/tps-v3/wiki/WS-Objects#documenttypes)
	- EInvoice Document - DocumentType=3 -(https://github.com/huginsdk/tps-v3/wiki/WS-JSON-Samples#invoice-document)
	- EArchive Document - DocumentType=4 -(https://github.com/huginsdk/tps-v3/wiki/WS-JSON-Samples#invoice-document)
	- Food Document (https://github.com/huginsdk/tps-v3/wiki/WS-JSON-Samples#food-document)
	- PrePayment Document (https://github.com/huginsdk/tps-v3/wiki/WS-JSON-Samples#prepayment-document)
	- InvoicePayment Document (https://github.com/huginsdk/tps-v3/wiki/WS-JSON-Samples#invoicepayment-document)
	- Parking Document (https://github.com/huginsdk/tps-v3/wiki/WS-JSON-Samples#parking-document)

- 	Receipt, Invoice, EInvoice, EArchive, Food --> Document(https://github.com/huginsdk/tps-v3/wiki/WS-Objects#document) + SalesDocument(https://github.com/huginsdk/tps-v3/wiki/WS-Objects#salesdocument)

- PrePayment -->  Document(https://github.com/huginsdk/tps-v3/wiki/WS-Objects#document) + PaymentInfo(https://github.com/huginsdk/tps-v3/wiki/WS-Objects#paymentinfo)

- Fields are using for InvoicePayment document.
	- "FoundationName": "ABC KURUMU" - string (max 30)
    - "SubscriberNo": "ABN18945" - string (max 15)
    - "CommisionAmount": 0.0 - decimal (max 999.999,99)  
	- "InvoiceTotal": 25.0 - decimal (max 999.999,99)
	
- This field using for InvoicePayment document.
	- "PlateNum": "58AT256" - string (max 8)

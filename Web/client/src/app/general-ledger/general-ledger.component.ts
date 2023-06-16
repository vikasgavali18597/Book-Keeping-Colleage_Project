import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-general-ledger',
  templateUrl: './general-ledger.component.html',
  styleUrls: ['./general-ledger.component.css']
})
export class GeneralLedgerComponent  {
  
  constructor() {
  }


  panelOpenState = true;

  

  // ngOnInit(): void {
  // }

  ledgers = [
    {
      name:"Cash At Bank",
      entries: [
        {
          name:"capital",
          type:"C",
          amount:"2000"
        }
      ]
    },
    {
      name:"Cash At Bank",
      entries: [
        {
          name:"capital",
          type:"D",
          amount:"30000"
        }
      ]
    },
    {
      name:"Cash At Bank",
      entries: [
        {
          name:"Machinery",
          type:"D",
          amount:"20000"
        }
      ]
    }
  ]

}

import { Component } from '@angular/core';

@Component({
  selector: 'app-ledger-table',
  templateUrl: './ledger-table.component.html',
  styleUrls: ['./ledger-table.component.css']
})
export class LedgerTableComponent {

  panelOpenState = false;

  ledgers = [
    {
      name:' Cash At Bank Account',
      table: [{
        name: 'Cash at bank',
        explanation: 'capital Account',
        drAmount: '',
        crAmount: '4000',
        balance: '20000',
        glnumber: 'Gl-20231706-1'
      },
      {
        name: 'Cash at bank',
        explanation: 'capital Account',
        drAmount: '4000',
        crAmount: '',
        balance: '20000',
        glnumber: 'Gl-20231706-1'
      },
      {
        name: 'Cash at bank',
        explanation: 'capital Account',
        drAmount: '',
        crAmount: '4000',
        balance: '20000',
        glnumber: 'Gl-20231706-1'
      },
      {
        name: 'Cash at bank',
        explanation: 'capital Account',
        drAmount: '',
        crAmount: '4000',
        balance: '20000',
        glnumber: 'Gl-20231706-1'
      }
    ]
    },
    {
      name:'Capital Account',
      table: [{
        name: 'Cash at bank',
        explanation: 'capital Account',
        drAmount: '4000',
        crAmount: '4000',
        balance: '20000',
        glnumber: 'Gl-20231706-1'
      },
      {
        name: 'Cash at bank',
        explanation: 'capital Account',
        drAmount: '',
        crAmount: '4000',
        balance: '20000',
        glnumber: 'Gl-20231706-1'
      },
      {
        name: 'Cash at bank',
        explanation: 'capital Account',
        drAmount: '',
        crAmount: '4000',
        balance: '20000',
        glnumber: 'Gl-20231706-1'
      },
      {
        name: 'Cash at bank',
        explanation: 'capital Account',
        drAmount: '4000',
        crAmount: '',
        balance: '20000',
        glnumber: 'Gl-20231706-1'
      }
    ]
    }
  ]
}

import { Component } from '@angular/core';

@Component({
  selector: 'app-ledger-wrapper',
  templateUrl: './ledger-wrapper.component.html',
  styleUrls: ['./ledger-wrapper.component.css']
})
export class LedgerWrapperComponent {
  ledgers = [
    {
      name:'Cash at bank',
      explanation: 'capital Account',
      drAmount: '',
      crAmount: '4000',
      balance: '20000'
    },
    {
      name:'Cash at bank',
      explanation: 'capital Account',
      drAmount: '',
      crAmount: '4000',
      balance: '20000'
    },
    {
      name:'Cash at bank',
      explanation: 'capital Account',
      drAmount: '',
      crAmount: '4000',
      balance: '20000'
    },
    {
      name:'Cash at bank',
      explanation: 'capital Account',
      drAmount: '',
      crAmount: '4000',
      balance: '20000'
    }
  ]

}

import { Component } from '@angular/core';

@Component({
  selector: 'app-journal-table',
  templateUrl: './journal-table.component.html',
  styleUrls: ['./journal-table.component.css']
})
export class JournalTableComponent {
   entries = [
    {
      date:'17/06/2023',
      glnumber:'GL-20230617-1',
      drAccount:'Cash At Bank',
      crAccount: 'Capital Account',
      drAmount: 4000,
      crAmount: 4000,
      narration: 'transaction done by developer'
    },
    {
      date:'17/06/2023',
      glnumber:'GL-20230617-1',
      drAccount:'Cash At Bank',
      crAccount: 'Capital Account',
      drAmount: 4000,
      crAmount: 4000,
      narration: 'transaction done by developer'
    },
    {
      date:'17/06/2023',
      glnumber:'GL-20230617-1',
      drAccount:'Cash At Bank',
      crAccount: 'Capital Account',
      drAmount: 4000,
      crAmount: 4000,
      narration: 'transaction done by developer'
    },
    {
      date:'17/06/2023',
      glnumber:'GL-20230617-1',
      drAccount:'Cash At Bank',
      crAccount: 'Capital Account',
      drAmount: 4000,
      crAmount: 4000,
      narration: 'transaction done by developer'
    },
    {
      date:'17/06/2023',
      glnumber:'GL-20230617-1',
      drAccount:'Cash At Bank',
      crAccount: 'Capital Account',
      drAmount: 4000,
      crAmount: 4000,
      narration: 'transaction done by developer'
    }
   ]
}

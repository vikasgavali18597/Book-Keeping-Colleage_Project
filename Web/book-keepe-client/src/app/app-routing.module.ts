import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { JournalWrapperComponent } from './journal/journal-wrapper/journal-wrapper.component';
import { LedgerWrapperComponent } from './ledger/ledger-wrapper/ledger-wrapper.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'home' },
  {
    path: 'home',
    component: DashboardComponent,
  },
  {
    path: 'journal',
    component: JournalWrapperComponent,
  }
  ,
  {
    path: 'ledger',
    component: LedgerWrapperComponent,

  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JournalComponent } from './journal/journal.component';
import { HomeComponent } from './home/home.component';
import { GeneralLedgerComponent } from './general-ledger/general-ledger.component';
import { LoginComponent } from './login/login.component';
import { NewJournalEntryFormComponent } from './journal/Add-Journals/new-journal-entry-form/new-journal-entry-form.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'home' },
  {
    path: 'home',
    component: HomeComponent,
  },
  {
    path: 'journal',
    component: JournalComponent,
  }
  ,
  {
    path: 'Gl',
    component: GeneralLedgerComponent,
  },
  {
    path:'add', component:NewJournalEntryFormComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

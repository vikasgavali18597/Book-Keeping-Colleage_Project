import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { JournalWrapperComponent } from './journal/journal-wrapper/journal-wrapper.component';

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
  // ,
  // {
  //   path: 'Gl',
  //   component: GeneralLedgerComponent,

  // }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { JournalComponent } from './journal/journal.component';
import { GeneralLedgerComponent } from './general-ledger/general-ledger.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SidebarComponent,
    JournalComponent,

  bootstrap: [AppComponent]
})
export class AppModule { }

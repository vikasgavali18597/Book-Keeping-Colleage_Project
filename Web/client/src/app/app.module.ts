import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { JournalComponent } from './journal/journal.component';
import { GeneralLedgerComponent } from './general-ledger/general-ledger.component';
import {MatIconModule} from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card'
import { LoginComponent } from './login/login.component';
import { AuthService } from './auth.service';
import {MatButtonModule} from '@angular/material/button';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NewJournalEntryFormComponent } from './journal/Add-Journals/new-journal-entry-form/new-journal-entry-form.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {MatExpansionModule} from '@angular/material/expansion';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SidebarComponent,
    JournalComponent,
    GeneralLedgerComponent,
    LoginComponent,
    NewJournalEntryFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    MatCardModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    MatButtonModule,
    NgbModule,
    MatExpansionModule,
    BrowserAnimationsModule
    // NgbModule.forRoot()
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }

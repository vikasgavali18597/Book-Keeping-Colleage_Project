import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { JournalWrapperComponent } from './journal/journal-wrapper/journal-wrapper.component';
import { JournalTableComponent } from './journal/journal-table/journal-table.component';
import { JournalFormComponent } from './journal/journal-form/journal-form.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule } from '@angular/material/dialog';
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatOptionModule } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { LedgerWrapperComponent } from './ledger/ledger-wrapper/ledger-wrapper.component';
import { LedgerTableComponent } from './ledger/ledger-table/ledger-table.component';
import { CdkAccordionModule } from '@angular/cdk/accordion';
import {MatExpansionModule} from '@angular/material/expansion';
import { HttpClientModule } from '@angular/common/http';
import { BookKeeperService } from './servises/book-keeper.service';


@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    JournalWrapperComponent,
    JournalTableComponent,
    JournalFormComponent,
    DashboardComponent,
    LedgerWrapperComponent,
    LedgerTableComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgbModule,
    MatButtonModule,
    MatIconModule,
    MatDialogModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatOptionModule,
    MatSelectModule,
    CdkAccordionModule,
    MatExpansionModule,
    HttpClientModule
  ],
  providers: [
    BookKeeperService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

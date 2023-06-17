import { Component, Inject } from '@angular/core';
import { JournalFormComponent } from '../journal-form/journal-form.component';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-journal-wrapper',
  templateUrl: './journal-wrapper.component.html',
  styleUrls: ['./journal-wrapper.component.css']
})
export class JournalWrapperComponent {

  /**
   *
   */
  constructor(public dialog: MatDialog) {}

  openDialog(enterAnimationDuration: string, exitAnimationDuration: string): void {
    this.dialog.open(JournalFormComponent, {
      width: '500px',
      // enterAnimationDuration,
      // exitAnimationDuration,
    });
  }

  popupComponent() {
    // this.dialogRef.op
  }
}

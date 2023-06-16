import { Component, Input, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms'
import { AuthService } from 'src/app/auth.service';

@Component({
  selector: 'app-new-journal-entry-form',
  templateUrl: './new-journal-entry-form.component.html',
  styleUrls: ['./new-journal-entry-form.component.css']
})
export class NewJournalEntryFormComponent implements OnInit {
 
  generalFormGroup?: FormGroup;

  categories:any[] = [
    {
      name:'Category'
    }
  ];
  account: any[] = [];
  generalForm?: FormGroup;
  constructor(private _auth: AuthService, private fb: FormBuilder) {
  }

  ngOnInit(): void {

    this.generalForm = this.fb.group({
      drCategory :['', Validators.required],
      crCategory :['', Validators.required],
      drAccount :['', Validators.required],
      crAccount :['', Validators.required],
      Amount :['', Validators.required],
      Naration :['', Validators.required]
    })


    this.getCategory();
  }

  getCategory() : void{
    this._auth.getAccountCategory().subscribe(data => {
      this.categories = data;
      console.log(data);
      });
  }

  getAccount(id:string): void{
    this._auth.getAccount(id).subscribe(data => {
      this.account = data;
    })
  }
}


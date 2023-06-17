import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-journal-form',
  templateUrl: './journal-form.component.html',
  styleUrls: ['./journal-form.component.css']
})
export class JournalFormComponent implements OnInit {
  myForm!: FormGroup;

  categories!: Category[];
  ngOnInit() {
    this.myForm = new FormGroup({
      name: new FormControl('Sammy'),
      email: new FormControl(''),
      message: new FormControl('')
    });
  }

  // onSubmit(form: FormGroup) {
  //   console.log('Valid?', form.valid); // true or false
  //   console.log('Name', form.value.name);
  //   console.log('Email', form.value.email);
  //   console.log('Message', form.value.message);
  // }

  onSelect(countryid: any) {
    // this.states = this.selectService.getStates().filter((item) => item.countryid == countryid);
  }

  isSubmitted = false;

  // City Names
  City: any = ['Florida', 'South Dakota', 'Tennessee', 'Michigan']

  constructor(public fb: FormBuilder) { }

  /*########### Form ###########*/
  registrationForm = this.fb.group({
    cityName: ['', [Validators.required]]
  })


  // Choose city using select dropdown
  changeCity(e: any) {
    // console.log(e.value)
    // // this.cityName.setValue(e.target.value, {
    //   onlySelf: true
    // })
  }

  // Getter method to access formcontrols
  get cityName() {
    return this.registrationForm.get('cityName');
  }

  /*########### Template Driven Form ###########*/
  onSubmit() {
    this.isSubmitted = true;
    if (!this.registrationForm.valid) {
      return false;
    } else {
      alert(JSON.stringify(this.registrationForm.value))
    }
    return 
  }





}


export class Category {
  id: string = '';
  name: string = '';
}

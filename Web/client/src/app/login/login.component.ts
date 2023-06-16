import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{

  /**
   *
   */
  constructor(private _authService: AuthService, private _router: Router) {
     
  }

  ngOnInit(): void {
    
  }
 
  loginUser() : void {
    // this._authService.login().then( () => {
    //   this._router.navigate([''])
    // })
  }

  logout() {
    localStorage.removeItem
  }
}

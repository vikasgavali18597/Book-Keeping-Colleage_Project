import { Component, Injectable, OnInit } from '@angular/core';
import { AuthService } from 'src/app/auth.service';


@Component({
  selector: 'app-journal',
  templateUrl: './journal.component.html',
  styleUrls: ['./journal.component.css']
})

@Injectable({
  providedIn: 'root'
})
export class JournalComponent implements OnInit{

  /**
   *
   */
  constructor(private auth: AuthService) {  
  }

  format(date: string) : string {

    var substring = date.substring(0, date.indexOf('T'))
    return substring;
  }

  ngOnInit(): void {
    // this.auth.getJournalEntries().subscribe(data => {
    //   console.log(data);
    // })

    this.refresh();
  }

  journals : any = [];
  refresh() {
    this.auth.getJournalEntries().subscribe(data => {
      this.journals = data;
      console.log(data);
    })
  }

}

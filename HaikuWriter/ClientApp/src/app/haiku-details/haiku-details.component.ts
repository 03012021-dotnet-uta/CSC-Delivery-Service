import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HaikuLine} from '../models/haiku-line.model';
import { HaikuService} from '../service/haiku.service';
import { Haiku } from '../models/haiku.model';
import { UserService} from '../service/user.service';
import { User } from '../models/user.model';

@Component({
  selector: 'app-haiku-details',
  templateUrl: './haiku-details.component.html',
  styleUrls: ['./haiku-details.component.css']
})
export class HaikuDetailsComponent implements OnInit {
  haikuLine = new HaikuLine(0," "," ",0,false, " ");
  haiku = new Haiku(0, " ", " ", " ", " ", false, " ");
  user = new User(" ", " ", " ", " ", " ", " ", " ", false);
  constructor(private haikuService: HaikuService,
      private router: Router,
     private userService: UserService) { }
     showSucessMessage?: boolean;
     showSucessMessage1?: boolean;
  ngOnInit(): void {
    const username = localStorage.getItem('User');

    if(username != null){
      this.haikuLine.username = username;
      this.haiku.username = username;
    }
    console.log(username);
    this.getUser(username);
  }

  SubmitHaikuLine()
  {
    
    this.haikuService.SubmitHaikuLine(this.haikuLine).subscribe(
      res => {
        this.showSucessMessage = true;
        setTimeout(() => this.showSucessMessage = false, 4000);
        console.log("success");
      },
      err => {
        console.log("server error");
      }
    );
  }

  SubmitHaiku()
  {
    this.haikuService.SubmitHaiku(this.haiku).subscribe(
      res => {
        this.showSucessMessage1 = true;
        setTimeout(() => this.showSucessMessage1 = false, 4000);
        console.log("success");
      },
      err => {
        console.log("server error");
        
      }
    );
  }

  getUser(username: string | null){
    this.userService.getUserByUserName(username)
      .subscribe(
        res => {
          this.user = res;
        },
        err => {
          console.log("server log")
        }
    );
  }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }

}

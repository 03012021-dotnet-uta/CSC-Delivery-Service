import { Component, OnInit } from '@angular/core';
import { HaikuLine} from '../models/haiku-line.model';
import { HaikuService} from '../service/haiku.service';
import { Haiku } from '../models/haiku.model';

@Component({
  selector: 'app-haiku-details',
  templateUrl: './haiku-details.component.html',
  styleUrls: ['./haiku-details.component.css']
})
export class HaikuDetailsComponent implements OnInit {
  haikuLine = new HaikuLine(0," "," ",0,false, " ");
  haiku = new Haiku(0, " ", " ", " ", " ", false, " ");

  constructor(private haikuService: HaikuService) { }

  ngOnInit(): void {
    const username = localStorage.getItem('User');
    if(username != null){
      this.haikuLine.username = username;
      this.haiku.username = username;
    }
    console.log(username);
  }

  SubmitHaikuLine()
  {
    
    this.haikuService.SubmitHaikuLine(this.haikuLine).subscribe(
      res => {
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
        console.log("success");
      },
      err => {
        console.log("server error");
      }
    );
  }

}

import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { HaikuLine} from '../models/haiku-line.model';
import { Haiku } from '../models/haiku.model';
import { User } from '../models/user.model';
import { HaikuService} from '../service/haiku.service';
import { UserService} from '../service/user.service';

@Component({
  selector: 'app-admin-approve',
  templateUrl: './admin-approve.component.html',
  styleUrls: ['./admin-approve.component.css']
})
export class AdminApproveComponent implements OnInit {
  haikulines: HaikuLine[] = [];
  haikus: Haiku[] =[];
  user = new User("", "", "", "", "", "", "", false);
  adminStatus: any;

  constructor(private haikuService: HaikuService, 
              private userService: UserService,
              private router: Router,
              private route: ActivatedRoute) { }

  ngOnInit(): void {
    const username = localStorage.getItem('User')
    this.getUser(username);
    this.adminStatus = localStorage.getItem("Admin");

    console.log("Admin approval" + this.adminStatus);
    if(username ==null)
    {
      this.router.navigateByUrl('/login')
    }
    if(this.adminStatus == "false")
    {
      this.router.navigateByUrl('/landingpage')
    }
    else{
      this.GetUnapprovedHaikuLines();
      this.GetUnapprovedHaikus();
    }
    
  }

  GetUnapprovedHaikuLines(): void {
    this.haikuService.GetUnapprovedHaikuLines().subscribe(res => {
      this.haikulines = res;
      console.log(res)}
      )
  }
  GetUnapprovedHaikus(): void {
    this.haikuService.GetUnapprovedHaikus().subscribe(res => {
      this.haikus = res;
      console.log(res);
    })
  }
  ApproveHaikuLine(hlid: number): void{
    this.haikuService.ApproveHaikuLine(hlid).subscribe(res => {
      res;
      console.log(res);
      this.ngOnInit();
    });
  }
  DeleteHaikuLine(hlid: number): void{
    this.haikuService.DeleteHaikuLine(hlid).subscribe(res => {
      res;
      console.log(res);
      this.ngOnInit();
    });
  }
  ApproveHaiku(hid: number): void{
    this.haikuService.ApproveHaiku(hid).subscribe(res => {
      res;
      console.log(res);
      this.ngOnInit();
    });
  }
  DeleteHaiku(hid: number): void{
    console.log(hid);
    this.haikuService.DeleteHaiku(hid).subscribe(res => {
      res;
      console.log(res);
      this.ngOnInit();
    });
  }

  getUser(username: string | null){
    this.userService.getUserByUserName(username)
      .subscribe(
        res => {
          
          this.user = res;
          console.log(res)
        },
        err => {
          if (err.status === 422) {
            console.log("server serror");
          }
          else{
            console.log("server error");
          }
        }
    );
  }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }
}

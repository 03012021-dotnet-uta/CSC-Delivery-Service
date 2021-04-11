import { Component, OnInit } from '@angular/core';
import { HaikuLine} from '../models/haiku-line.model';
import { HaikuService} from '../service/haiku.service';

@Component({
  selector: 'app-admin-approve',
  templateUrl: './admin-approve.component.html',
  styleUrls: ['./admin-approve.component.css']
})
export class AdminApproveComponent implements OnInit {
  haikulines: HaikuLine[] = [];
  
  constructor(private haikuService: HaikuService) { }

  ngOnInit(): void {
    this.GetUnapprovedHaikuLines();
  }

  GetUnapprovedHaikuLines(): void {
    this.haikuService.GetUnapprovedHaikuLines().subscribe(res => this.haikulines = res)
  }
}

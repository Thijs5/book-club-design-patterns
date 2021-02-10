export class Television {
  public readonly menu = [
    'My List',
    'Popular',
    'Search',
    'Trending',
  ];

  private selectedMenu = 0;

  private poweredOn = false;

  get isPoweredOn(): boolean {
    return this.poweredOn;
  }

  public MoveUp() {
    if (this.selectedMenu > 0) {
      this.selectedMenu--;
    }
  }

  public MoveDown() {
    if (this.selectedMenu < this.menu.length - 1) {
      this.selectedMenu++;
    }
  }

  public ToggleOn() {
    this.poweredOn = !this.poweredOn;
  }
}

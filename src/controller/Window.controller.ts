import { BrowserWindow } from 'electron'

export class WindowController {
  public closeWindow (window: BrowserWindow) {
    window.close()
  }

  public maximiseWindow (window: BrowserWindow) {
    if (window.isMaximized()) {
      window.unmaximize()
    } else {
      window.maximize()
    }
  }

  public minimiseWindow (window: BrowserWindow) {
    window.minimize()
  }
}
